int pin1=A0;
int pin2=2;

int data1;
int data2;
void setup() {
  
Serial.begin(9600);
pinMode(pin1,INPUT);
pinMode(pin2, INPUT);
}



void loop(){
data1= analogRead(pin1);
data2=digitalRead(pin2);

Serial.print(data1);
Serial.print(",");
Serial.println(data2);
Serial.flush();
delay(10);
  
}
