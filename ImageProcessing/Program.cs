using GrayScale;
using Histogram;
using HistogramEqualization;
using Microsoft.Extensions.DependencyInjection;
using Negative;
using SpatialFiltering;
using static ImageProcessing.Managers;
using Thresholding;
using GrayScaleForm = ImageProcessing.AppForms.GrayScaleForm;
using HistogramEqForm = ImageProcessing.AppForms.HistogramEqForm;
using HistogramForm = ImageProcessing.AppForms.HistogramForm;
using MainForm = ImageProcessing.AppForms.MainForm;
using NegativeForm = ImageProcessing.AppForms.NegativeForm;
using ThresholdingForm = ImageProcessing.AppForms.ThresholdingForm;

namespace ImageProcessing
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var mainForm = serviceProvider.GetRequiredService<MainForm>();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
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
            services.AddTransient<AppForms.SpatialFiltering>();
        }
    }
}