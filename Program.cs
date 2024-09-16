using sistema_celular_C_;
using sistema_celular_C_.Smarphone;

Nokia nokia = new Nokia();
nokia.MarcaCelular();
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

Iphone iphone = new Iphone();
iphone.MarcaCelular();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
