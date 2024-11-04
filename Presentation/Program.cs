using System;
using System.Linq;
using System.Windows.Forms;
using GrayScale;
using Histogram;
using HistogramEqualization;
using Microsoft.Extensions.DependencyInjection;
using Negative;
using Presentation.Forms;
using SpatialFiltering;
using Thresholding;
using static Presentation.Managers;

namespace Presentation
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var mainForm = serviceProvider.GetRequiredService<MainForm>();

            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(mainForm);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // ثبت سرویس‌ها
            services.AddSingleton<IImageGrayScale, ImageGrayScale>();
            services.AddSingleton<IImageHistogram, ImageHistogram>();
            services.AddSingleton<IImageHistogramEqualization, ImageHistogramEqualization>();
            services.AddSingleton<IImageNegative, ImageNegative>();
            services.AddSingleton<IImageThresholding, ImageThresholding>();
            services.AddSingleton<IImageSpatialFiltering, ImageSpatialFiltering>();

            // ثبت مدیریت سرویس‌ها
            services.AddSingleton<ServiceManager>();

            // ثبت فرم‌ها
            services.AddTransient<MainForm>();
            services.AddTransient<GrayScaleForm>();
            services.AddTransient<HistogramForm>();
            services.AddTransient<HistogramEqForm>();
            services.AddTransient<NegativeForm>();
            services.AddTransient<ThresholdingForm>();
            services.AddTransient<SpatialAndMedianFilteringForm>();
        }
    }
}