using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Diseños
{
    public static class CueHelper
    {
        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, string lParam);

        public static void SetCue(TextBox textBox, string cue, bool showWhenFocused = false)
        {
            if (textBox == null) throw new ArgumentNullException(nameof(textBox));

            void Apply()
            {
                SendMessage(textBox.Handle, EM_SETCUEBANNER, showWhenFocused ? new IntPtr(1) : IntPtr.Zero, cue);
            }

            if (textBox.IsHandleCreated)
            {
                Apply();
            }
            else
            {
                // Aplicar cuando se cree el handle (útil si llamas antes de InitializeComponent terminado)
                textBox.HandleCreated += (s, e) => Apply();
            }
        }
    }

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            // Reemplaza 'txtUsuario' y 'txtPassword' por los nombres reales de tus TextBox
            CueHelper.SetCue(txtuser, "Introduce tu usuario");
            CueHelper.SetCue(txtpass, "Contraseña", showWhenFocused: false);
        }
    }
}