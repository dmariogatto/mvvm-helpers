namespace MvvmHelpers
{
	/// <summary>
	/// Base view model.
	/// </summary>
	public class BaseViewModel : ObservableObject
	{
		private string? _title = string.Empty;

		/// <summary>
		/// Gets or sets the title.
		/// </summary>
		/// <value>The title.</value>
		public string? Title
		{
			get => _title;
			set => SetProperty(ref _title, value);
		}

		private bool _isBusy;

		/// <summary>
		/// Gets or sets a value indicating whether this instance is busy.
		/// </summary>
		/// <value><c>true</c> if this instance is busy; otherwise, <c>false</c>.</value>
		public bool IsBusy
		{
			get => _isBusy;
			set
			{
                if (SetProperty(ref _isBusy, value))
                    OnPropertyChanged(nameof(IsNotBusy));
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether this instance is not busy.
		/// </summary>
		/// <value><c>true</c> if this instance is not busy; otherwise, <c>false</c>.</value>
		public bool IsNotBusy
		{
			get => !_isBusy;
			set
			{
				if (SetProperty(ref _isBusy, !value))
                    OnPropertyChanged(nameof(IsBusy));
            }
		}
	}
}


