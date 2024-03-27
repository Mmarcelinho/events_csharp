namespace Events.Demo01;

    public class MudancaTemperaturaEventArgs : EventArgs
    {
        public double TemperaturaAnterior { get; }

        public double TemperaturaAtual { get; }

        public MudancaTemperaturaEventArgs(double temperaturaAnterior, double temperaturaAtual)
        {
            TemperaturaAnterior = temperaturaAnterior;
            TemperaturaAtual = temperaturaAtual;
        }
    }

