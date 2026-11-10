// Paskaidrojums (b): Lasīšana ir atsevišķā interfeisā ILogReader, lai klasēm, kas ziņas nevar nolasīt
// (piemēram, ConsoleLogger), nebūtu jāīsteno nevajadzīga metode – labāk vairāki mazi interfeisi nekā
// viens liels. To prasa Interface Segregation princips (I).
public interface ILogReader
{
    List<string> GetMessages();
}
