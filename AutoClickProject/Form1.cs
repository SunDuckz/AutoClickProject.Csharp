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

        private int clickInterval; // intervalo de tempo entre os cliques em milissegundos

        public Form1()
        {
            InitializeComponent();
        }





        public async void startAutoClicker(object Sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Modo Preciso")
            {
                // Modo preciso: clique a cada 100ms
                clickInterval = 100;
            }
            else if (comboBox1.SelectedItem.ToString() == "Modo Variado")
            {
                // Modo variado: clique a cada 100-500ms
                clickInterval = random.Next(100, 500);
            }
            // executa o clique
            timer.Start();
            timer.Interval = clickInterval; // define o intervalo de tempo entre os cliques
            timer.Tick += (s, args) =>
            {
                Clicar(); // chama o método de clique
            };

           
               await Task.Delay(20000);

               
               timer.Stop(); // para o temporizador após 20 segundos
               MessageBox.Show("O tempo de clique automático terminou.");
              
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
