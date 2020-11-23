using API.Models;
using lotto_DB.lottoContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace lotto_DB
{
    public class lottoDBContext : LocaldbMssqllocaldbContext
    {
        private readonly AppsettingModel _configuration;

        public lottoDBContext(IOptions<AppsettingModel> configuration)
        {
            _configuration = configuration.Value;
        }

        public lottoDBContext(DbContextOptions<LocaldbMssqllocaldbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_configuration.ConnectionStrings.LOTTODB);
            }
        }
    }
}
