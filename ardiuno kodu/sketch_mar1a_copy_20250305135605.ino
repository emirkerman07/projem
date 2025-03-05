void setup() {
  Serial.begin(9600);
  while (!Serial) {
    ; // Seri portun hazır olmasını bekle
  }
}

void loop() {
  int hiz = random(1, 250);          // Hız: 0-119 arası
  int kilometre = random(1, 1000);   // Kilometre: 0-999 arası
  int pil = random(1, 101);          // Pil yüzdesi: 0-100 arası
  int pilSicakligi = random(30, 76); // Pil sıcaklığı: 20-59 arası

  Serial.println("Hiz: " + String(hiz));
  Serial.println("Kilometre: " + String(kilometre));
  Serial.println("Pil: " + String(pil));
  Serial.println("Pil Sicakligi: " + String(pilSicakligi));

  delay(1000); // 1 saniye bekle
}