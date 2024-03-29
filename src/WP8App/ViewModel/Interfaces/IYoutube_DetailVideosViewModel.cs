// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   IViewModel.tt
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Entities=WPAppStudio.Entities;
using EntitiesBase=WPAppStudio.Entities.Base;

namespace WPAppStudio.ViewModel.Interfaces
{
    /// <summary>
    /// Youtube_DetailVideos ViewModel interface.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public interface IYoutube_DetailVideosViewModel
    {		
        /// <summary>
        /// Gets/Sets the CurrentYouTubeVideo property.
        /// </summary>
		EntitiesBase.YouTubeVideo CurrentYouTubeVideo { get; set; }
        /// <summary>
        /// Gets/Sets the HasNextpanoramaYoutube_DetailVideos0 property.
        /// </summary>
		bool HasNextpanoramaYoutube_DetailVideos0 { get; set; }
        /// <summary>
        /// Gets/Sets the HasPreviouspanoramaYoutube_DetailVideos0 property.
        /// </summary>
		bool HasPreviouspanoramaYoutube_DetailVideos0 { get; set; }
        
        /// <summary>
        /// Gets the TextToSpeechYoutube_DetailVideosStaticControlCommand command.
        /// </summary>
		ICommand TextToSpeechYoutube_DetailVideosStaticControlCommand { get; }

        
        /// <summary>
        /// Gets the ShareYoutube_DetailVideosStaticControlCommand command.
        /// </summary>
		ICommand ShareYoutube_DetailVideosStaticControlCommand { get; }

        
        /// <summary>
        /// Gets the PinToStartYoutube_DetailVideosStaticControlCommand command.
        /// </summary>
		ICommand PinToStartYoutube_DetailVideosStaticControlCommand { get; }

        
        /// <summary>
        /// Gets the GoToSourceYoutube_DetailVideosStaticControlCommand command.
        /// </summary>
		ICommand GoToSourceYoutube_DetailVideosStaticControlCommand { get; }

        
        /// <summary>
        /// Gets the NextpanoramaYoutube_DetailVideos0 command.
        /// </summary>
		ICommand NextpanoramaYoutube_DetailVideos0 { get; }

        
        /// <summary>
        /// Gets the PreviouspanoramaYoutube_DetailVideos0 command.
        /// </summary>
		ICommand PreviouspanoramaYoutube_DetailVideos0 { get; }

	}
}
