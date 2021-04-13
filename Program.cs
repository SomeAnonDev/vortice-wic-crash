using System.IO;
using Vortice.WIC;

using FileStream stream = File.OpenRead("LuLu.png");
using var wicFactory = new IWICImagingFactory();
using IWICStream wicStream = wicFactory.CreateStream(stream);