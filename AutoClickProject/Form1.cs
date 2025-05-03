using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace AutoClickProject
{
    public partial class Form1 : Form
    {
        // variaveis              // codigo hexadecimal para facilitar leitura do codigo para o computador
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        // metodo que executa o evento de clique
        [DllImport("user32.dll",
            CharSet = CharSet.Auto,
            CallingConvention = CallingConvention.StdCall)]

        // evento do mouse 
        public static extern void mouse_event(
            int dwFlags,
            int dx,
            int dy,
            int cButtons,
            int dwExtraInfo);

        private Random random = new(); // gera numeros aleatorios 
        private System.Windows.Forms.Timer timer = new(); // cria um temporizador para o clique automatico
        private System.Windows.Forms.Timer timerSecundario = new(); // cria um temporizador para o clique automatico
        private int clickInterval; // intervalo de tempo entre os cliques em milissegundos
        private List<int> clickIntervalList; // array para armazenar os intervalos de tempo entre os cliques
        private int valor;
        public Form1()
        {
            InitializeComponent();
        }




        public async void startAutoClicker(object Sender, EventArgs e)
        {
            int valorAntes = (trackBar1.Value - 1 <= 0) ? 1 : trackBar1.Value - 1 ;
            int valorMeio = (trackBar1.Value <= 0) ? 1 : trackBar1.Value;
            int valorDepois = (trackBar1.Value + 1 <= 0) ? 1 : trackBar1.Value + 1;

            clickIntervalList = new List<int> {1000 / valorAntes, 1000 / valorMeio, 1000 / valorDepois };


            if (comboBox1.SelectedItem.ToString() == "Modo Preciso")
            {

                clickInterval = clickIntervalList[1];
            }
            else if (comboBox1.SelectedItem.ToString() == "Modo Variado")
            {
                timerSecundario.Start();
                timerSecundario.Interval = 1000; 
                timerSecundario.Tick += (s, args) =>
                {
                    // gera um numero aleatorio entre 0 e 2
                    valor = random.Next(clickIntervalList.Count);
                    // pega o intervalo de tempo aleatorio da lista
                    clickInterval = clickIntervalList[valor];
                };
            }
            // executa o clique
            timer.Start();
            timer.Interval = clickInterval; // define o intervalo de tempo entre os cliques
            timer.Tick += (s, args) =>
            {

                Clicar(); // chama o método de clique
            };


            await Task.Delay(10000);


            timer.Stop(); // para o temporizador após 20 segundos
            timerSecundario.Stop();
        }


        public void label2toTrackbar(object sender,EventArgs e)
        {
            // converte o valor do trackbar para o label
            label2.Text = trackBar1.Value.ToString();

        }

        private void Clicar()
        {
            // executa o clique completo do mouse
            // pressiona o botao esquerdo do mouse
            mouse_event(MOUSEEVENTF_LEFTDOWN, Cursor.Position.X, Cursor.Position.Y, 0, 0);
            // solta o botão esquerdo do mouse
            mouse_event(MOUSEEVENTF_LEFTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);
        }

    }
}
