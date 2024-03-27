namespace Events.Demo01;

    public class Termometro
    {
        private double _temperaturaAtual;

        public event EventHandler<MudancaTemperaturaEventArgs> EventoDeMudancaDeTemperatura;

        public Termometro(double temperaturaInicial)
        {
            _temperaturaAtual = temperaturaInicial;
        }

        public void AtualizarTemperatura(double novaTemperatura)
        {
            if(Math.Abs(novaTemperatura - _temperaturaAtual) >= 0.1)
            {
                MudancaTemperaturaEventArgs args = new(_temperaturaAtual, novaTemperatura);

                _temperaturaAtual = novaTemperatura;
                AoMudarTemperatura(args);
            }
        }

        protected virtual void AoMudarTemperatura(MudancaTemperaturaEventArgs e)
        {
            EventoDeMudancaDeTemperatura?.Invoke(this, e);
        }
    }
