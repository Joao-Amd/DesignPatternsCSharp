﻿using System;

namespace Estrutural.Bridge.Platforms
{
    public class YouTube : IPlatform
    {
        public YouTube()
        {
            ConfigureRMTP();
            Console.WriteLine("YouTube: Transmissão Iniciada.");
        }
        public void AuthToken()
        {
            Console.WriteLine("YouTube: Autorizando aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("YouTube: Configurando servidor RMTP.");
        }
    }
}
