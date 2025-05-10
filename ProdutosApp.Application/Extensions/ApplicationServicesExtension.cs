﻿using Microsoft.Extensions.DependencyInjection;
using ProdutosApp.Application.Interfaces;
using ProdutosApp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosApp.Application.Extensions
{
    /// <summary>
    /// Classe de extensão para configuração de injeção de dependência
    /// dos serviços da camada de aplicação
    /// </summary>
    public static class ApplicationServicesExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoriaAppService, CategoriaAppService>();

            return services;
        }
    }
}



