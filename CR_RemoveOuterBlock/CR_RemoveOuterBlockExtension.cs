using System.ComponentModel.Composition;
using DevExpress.CodeRush.Common;

namespace CR_RemoveOuterBlock
{
  [Export(typeof(IVsixPluginExtension))]
  public class CR_RemoveOuterBlockExtension : IVsixPluginExtension { }
}