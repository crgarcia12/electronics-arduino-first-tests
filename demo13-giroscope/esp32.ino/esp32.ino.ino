const int TEMP_GPIO = 11;

void setup() 
{
   Serial.begin(115200);

   pinMode(TEMP_GPIO, OUTPUT); 
}

void loop()
{
    Serial.println("running");  
    analogWrite(TEMP_GPIO, 128); 
}
