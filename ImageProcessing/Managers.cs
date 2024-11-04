using GrayScale;
using Histogram;
using HistogramEqualization;
using Negative;
using SpatialFiltering;
using Thresholding;

namespace ImageProcessing
{
    public class Managers
    {
        public class ServiceManager
        {
            public IImageGrayScale ImageGrayScaleService { get; set; }
            public IImageHistogram ImageHistogramService { get; set; }
            public IImageHistogramEqualization ImageHistogramEqualizationService { get; set; }
            public IImageNegative ImageNegativeService { get; set; }
            public IImageThresholding ImageThresholdingService { get; set; }
            public IImageSpatialFiltering ImageSpatialFilteringService { get; set; }



            public ServiceManager(IImageGrayScale imageGrayScaleService, IImageHistogram imageHistogramService, IImageHistogramEqualization imageHistogramEqualizationService, IImageNegative imageNegativeService, IImageThresholding imageThresholdingService, IImageSpatialFiltering imageSpatialFilteringService)
            {
                ImageGrayScaleService = imageGrayScaleService;
                ImageHistogramService = imageHistogramService;
                ImageHistogramEqualizationService = imageHistogramEqualizationService;
                ImageNegativeService = imageNegativeService;
                ImageThresholdingService = imageThresholdingService;
                ImageSpatialFilteringService = imageSpatialFilteringService;
            }
        }
    }
}
