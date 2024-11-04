using GrayScale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Histogram;
using HistogramEqualization;
using Negative;
using SpatialFiltering;
using Thresholding;

namespace Presentation
{
    public class Managers
    {
        public class ServiceManager
        {
            public IImageGrayScale ImageGrayScaleService { get; }
            public IImageHistogram ImageHistogramService { get; }
            public IImageHistogramEqualization ImageHistogramEqualizationService { get; }
            public IImageNegative ImageNegativeService { get; }
            public IImageThresholding ImageThresholdingService  { get; }
            public IImageSpatialFiltering ImageSpatialFilteringService { get; }



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
