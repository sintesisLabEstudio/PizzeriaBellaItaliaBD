using System;
using System.Windows.Forms;
using PizzeriaBellaItalia.Presentacion;

namespace PizzeriaBellaItalia;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new FormPedido());
    }
}