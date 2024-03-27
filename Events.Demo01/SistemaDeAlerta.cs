namespace Events.Demo01;

    public class SistemaDeAlerta
    {
        public void InscreverNoEventoDeMudancaDeTemperatura(Termometro termometro)
        {
            termometro.EventoDeMudancaDeTemperatura += AlertarMudancaDeTemperatura;
        }

        public void DesinscreverNoEventoDeMudancaDeTemperatura(Termometro termometro)
        {
            termometro.EventoDeMudancaDeTemperatura -= AlertarMudancaDeTemperatura;
        }

        private void AlertarMudancaDeTemperatura(object sender, MudancaTemperaturaEventArgs e)
        {
            Console.WriteLine($"Alerta! Temperatura mudou de {e.TemperaturaAnterior} para {e.TemperaturaAtual} graus.");
        }
    }
