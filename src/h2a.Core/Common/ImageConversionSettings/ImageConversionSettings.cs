﻿using ImageMagick;

namespace h2a.Core.ImageConversion.Settings;

public record ImageConversionSettings(string FolderPath, MagickFormat DesiredFormat);