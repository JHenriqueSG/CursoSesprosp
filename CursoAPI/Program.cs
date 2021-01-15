using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoAPI
{
    public class Program
    {
#pragma warning disable CS1591 // O coment�rio XML ausente n�o foi encontrado para o tipo ou membro vis�vel publicamente
        public static void Main(string[] args)
#pragma warning restore CS1591 // O coment�rio XML ausente n�o foi encontrado para o tipo ou membro vis�vel publicamente
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
