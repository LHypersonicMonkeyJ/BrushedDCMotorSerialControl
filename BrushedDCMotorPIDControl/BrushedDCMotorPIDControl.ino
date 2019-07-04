/*
 * Brushed DC Motor PID Control
 * Function of this code:
 *  (1) Receive command from Visual Studio: set_speed, kP, kI, kD
 *  (2) Control motor speed through PWM (PWM is based on PID calculation)
 *  (3) Send pv_speed to Visual Studio to show in graph
 *  
 *  Date Created: 06/29/2019
 *  Name: LJDiscovery
 *  Credit: http://engineer2you.blogspot.com
 */

//***************************Communication**********************************
String mySt = "";
char myChar;
bool stringComplete = false;
bool motor_start = false;
//***************************Encoder and Motor Control**********************************
const uint8_t encoder_A = 2;
const uint8_t encoder_B = 3;
const uint8_t motor_IN1 = 12;
const uint8_t motor_IN2 = 13;
const uint8_t motor_ENA = 7;
const uint16_t t1_comp = 6250;  // 16 bit timer counter = maximum of 65,535 counts
                                // pre-scaler 256 and 100ms interrupt -> 0.1*16e6/256 = 6250
volatile long counter = 0;      //Encoder Counter    
bool m_direction;                           
//***************************PID**********************************     
int sv_speed = 100;             //Set value (PWM) (this value is 0~255)                           
double pv_speed = 0;            //Previous speed
double set_speed = 0;           //Set speed
double e_speed = 0;             //Error of speed = set_speed - pv_speed
double e_speed_pre = 0;         //last error of speed
double e_speed_sum = 0;         //sum error of speed
double pwm_pulse = 0;           //PWM control
double kp = 0;
double ki = 0;
double kd = 0;

//***************************Main**********************************    
void setup() {
  arduinoPinSetup();
  breakNow();
  //floatNow();
  //A rising pulse from encodenren activated ai0(). AttachInterrupt 0 is DigitalPin nr 2 on moust Arduino.
  attachInterrupt(0, detect0, FALLING);
  Serial.begin (9600);
  Serial.println("start...");
  noInterrupts();
  timerInterruptSetup();
  interrupts();
  sei(); //Enable global interrupts
  //while (!Serial) {
  //  ; // wait for serial port to connect. Needed for native USB port only
  //}
}

void loop() {
  if (stringComplete) {
    // clear the string when COM receiving is completed
    mySt = "";  //Note: in code below, mySt will not become blank, mySt is blank until '\n' is received
  }

  //Receive command from Visual Studio
  if (mySt.substring(0,8) == "vs_start") {
    CWspin();
    motor_start = true;
  }
  if (mySt.substring(0,7) == "vs_stop") {
    breakNow();
    motor_start = false;
  }
  if (mySt.substring(0,12) == "vs_set_speed") {
    set_speed = mySt.substring(12,mySt.length()).toFloat();     //get string after set_speed
  }
  if (mySt.substring(0,5) == "vs_kp") {
    kp = mySt.substring(5,mySt.length()).toFloat();             //get string after vs_kp
  }
  if (mySt.substring(0,5) == "vs_ki") {
    ki = mySt.substring(5,mySt.length()).toFloat();             //get string after vs_ki
  }
  if (mySt.substring(0,5) == "vs_kd") {
    kd = mySt.substring(5,mySt.length()).toFloat();             //get string after vs_kd
  }
}

//***************************Functions**********************************    
void arduinoPinSetup() 
{
  pinMode(encoder_A, INPUT_PULLUP);
  pinMode(encoder_B, INPUT_PULLUP);
  pinMode(motor_IN1, OUTPUT);
  pinMode(motor_IN2, OUTPUT);
  pinMode(motor_ENA, OUTPUT);
}

//*********Timer Interrupt 100ms*********
void timerInterruptSetup() 
{
  TCCR1A = 0; // Reset Timer 1 control register A

  // Clear Timer on Compare Match Mode
  TCCR1B &= ~(1 << WGM13);
  TCCR1B |= (1 << WGM12);

  // Set to prescaler of 256
  TCCR1B |= (1 << CS12);
  TCCR1B &= ~(1 << CS11);
  TCCR1B &= ~(1 << CS10);

  TCNT1 = 0; // Reset Timer 1
  OCR1A = t1_comp; // Set output compare value

  TIMSK1 |= (1<<OCIE1A); // Enable Timer1 compare interrupt
}

//*********Timer ISR tick every 100ms*********
ISR(TIMER1_COMPA_vect) {
  pv_speed = counter*5/3; //calculate motor speed, unit is rpm counter/360*60/0.1
  counter = 0;
  //print out speed to serial when no new instruction
  if (Serial.available() <= 0) {
    Serial.print("speed");
    Serial.println(pv_speed);     //Print speed (rpm) value to Visual Studio
  }

  //PID-------------------------!!!!!
  if (motor_start) {
    e_speed = set_speed - pv_speed;
    pwm_pulse = e_speed*kp + e_speed_sum*ki + (e_speed - e_speed_pre)*kd;
    e_speed_pre = e_speed;
    e_speed_sum += e_speed; //sum of error
    if (e_speed_sum > 4000) e_speed_sum = 4000;
    if (e_speed_sum < -4000) e_speed_sum = -4000;
  }
  else {
    e_speed = 0;
    e_speed_pre = 0;
    e_speed_sum = 0;
    pwm_pulse = 0;
  }

  //-----------Update New Speed--------
   if (pwm_pulse < 255 && pwm_pulse > 0) {
    analogWrite(motor_ENA, pwm_pulse); // Set motor speed
   }
   else {
    if (pwm_pulse > 255) {
      analogWrite(motor_ENA, 255);
    }
    else {
      analogWrite(motor_ENA, 0);
    }
   }
}

//*********External Pin Interrupt*********
void detect0() {
  // detect0 is activated if DigitalPin nr 2 is going from LOW to HIGH
  // Check pin 3 to determine the direction
  counter++;
  m_direction = digitalRead(encoder_B);
}

//*********Motor H-bridge Control Functions*********
void CWspin() 
{
  digitalWrite(motor_IN1, HIGH);  
  digitalWrite(motor_IN2, LOW); 
  //delay(50);
}

void CCWspin()
{
  digitalWrite(motor_IN1, LOW);
  digitalWrite(motor_IN1, HIGH);
  //delay(50);
}

void breakNow()
{
  digitalWrite(motor_IN1, HIGH);
  digitalWrite(motor_IN1, HIGH);
  delay(200);
}

void floatNow()
{
  digitalWrite(motor_IN1, LOW);
  digitalWrite(motor_IN2, LOW);
  //delay(50);
}

//*********Serial Event Function*********
void serialEvent() {
  while (Serial.available()) {
    // get the new byte:
    char inChar = (char)Serial.read();
    // add it to the inputString:
    if (inChar != '\n') {
      mySt += inChar;
    }
    // if the incoming character is a newline, set a flag
    // so the main loop can do something about it:
    if (inChar == '\n') {
      stringComplete = true;
    }
  }
}
