using System;

namespace ListDataStructure
{
    public class Filters
    {
        private string _nameFilter;
        private string _ageFilter;
        private EventHandler onValueChanged;
        public string NameFilter
        {
            get => _nameFilter;
            set
            {
                _nameFilter = value;
                OnValueChanged(EventArgs.Empty);
            }
        }
        public string AgeFilter
        {
            get => _ageFilter;
            set
            {
                _ageFilter = value;
                OnValueChanged(EventArgs.Empty);
            }
        }
        public string AllFilters
        {
            get
            {
                return $"{NameFilter} {AgeFilter}";
            }
        }
        public event EventHandler ValueChanged
        {
            add { onValueChanged += value; }
            remove { onValueChanged -= value; }
        }
        protected virtual void OnValueChanged(EventArgs e)
        {
            onValueChanged?.Invoke(this, e);
        }
    }
}
