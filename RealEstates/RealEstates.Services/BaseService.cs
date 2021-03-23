using AutoMapper;
using RealEstates.Services.Profiler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstates.Services
{
    public abstract class BaseService
    {
        public BaseService()
        {
            InitializeAutoMapper();
        }

        protected IMapper Mapper { get; private set; }

        private void InitializeAutoMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<RealEstateProfiler>();
            });

            this.Mapper = config.CreateMapper();
        }
    }
}
