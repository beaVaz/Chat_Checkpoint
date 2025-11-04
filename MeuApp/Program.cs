
Console.WriteLine("Para qual canal você deseja enviar a mensagem?");
Console.WriteLine("1, Whatsapp");
Console.WriteLine("2, Telegram");
Console.WriteLine("3, Instagram");
Console.WriteLine("4, Facebook");

int canal = 0;
string resposta = Console.ReadLine();
if (!int.TryParse(resposta, out canal))
{
    Console.WriteLine("Opção inválida");
    return;
}

MessageBase messageBase = new TextMessage("Olá");
if (canal == 1)
{
    var whats = new WhatsApp();
    whats.EnviarMensagem("12345678", messageBase);

    whats.EnviarMensagem ("87654321", video);
}
