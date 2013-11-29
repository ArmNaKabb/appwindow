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
    /// Youtube_Videos ViewModel interface.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public interface IYoutube_VideosViewModel
    {		
        /// <summary>
        /// Gets/Sets the Youtube_VideosListControlCollection property.
        /// </summary>
		ObservableCollection<EntitiesBase.YouTubeVideo> Youtube_VideosListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the Youtube_VideosListControlCollectionPageNumber property.
        /// </summary>
		int Youtube_VideosListControlCollectionPageNumber { get; set; }
        /// <summary>
        /// Gets/Sets the SelectedYoutube_VideosListControlCollection property.
        /// </summary>
		EntitiesBase.YouTubeVideo SelectedYoutube_VideosListControlCollection { get; set; }
        
        /// <summary>
        /// Gets the RefreshYoutube_VideosListControlCollectionCommand command.
        /// </summary>
		ICommand RefreshYoutube_VideosListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the GetYoutube_VideosListControlCollectionCommand command.
        /// </summary>
		ICommand GetYoutube_VideosListControlCollectionCommand { get; }

	}
}
