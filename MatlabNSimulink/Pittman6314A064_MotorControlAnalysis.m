clear; close all; clc
% Brushed DC Motor Data
% PITTMAN Motor P# 6314A064-R3
J = 6.62e-4;    % kg*m^2 was 2.41e-6
b = 2e-5;       % Nm/s------------Note: this is estimated not actual value, s is rad/s
K = 0.02626;    % V/s
R = 2.861;      % Ohm
L = 1.57e-3;    % H

% Transfer Function
s = tf('s');
P_motor = K/((J*s + b)*(L*s+R)+K^2);
zpk(P_motor)
[z, p, k] = zpkdata(P_motor, 'v')

% PID Control Method
kp = 0.16;
ki = 0.06;
kd = 0;
C = pid(kp, ki, kd);
pidTuner(P_motor, C)

step(P_motor)
P_pid = feedback(C*P_motor, 1);
step(P_pid)