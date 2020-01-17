const int TempPort = A1;
const int NTC_R25 = 10000; // the resistance of the NTC at 25'C is 10k ohm
const int NTC_MATERIAL_CONSTANT = 3950; // value provided by manufacturer

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  
  pinMode(TempPort, INPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  Serial.println(get_temperature());
  
}


float get_temperature()
{
  float temperature, resistance;
  int value;
  value = analogRead(TempPort);
  resistance   = (float)value * NTC_R25 / (1024 - value); // Calculate resistance
  /* Calculate the temperature according to the following formula. */
  temperature  = 1 / (log(resistance / NTC_R25) / NTC_MATERIAL_CONSTANT + 1 / 298.15) - 273.15;
  return temperature;
}
