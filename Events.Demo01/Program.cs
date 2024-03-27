namespace Events.Demo01;

public class Program
{
    static void Main()
    {
        Termometro termometro = new(25.0);

        SistemaDeAlerta sistemaDeAlerta = new();

        //Inscrição no evento
        sistemaDeAlerta.InscreverNoEventoDeMudancaDeTemperatura(termometro);

        Console.WriteLine("Atualizando temperaturas:");
        termometro.AtualizarTemperatura(25.05);
        termometro.AtualizarTemperatura(25.2);
        termometro.AtualizarTemperatura(25.1);
        termometro.AtualizarTemperatura(24.0);

        //Desinscição no evento
        sistemaDeAlerta.DesinscreverNoEventoDeMudancaDeTemperatura(termometro);
    }
}