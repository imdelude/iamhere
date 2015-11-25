using System;
using System.Collections.Generic;
using iamhere.Responses.Geocoding.Contract;

namespace iamhere.Responses.Geocoding.Raw
{
    public class ViewAdapter : IView
    {
        private readonly View _view;

        public int? ViewId => _view.ViewId;

        private List<IResult> _results;
        public IReadOnlyCollection<IResult> Results
        {
            get
            {
                if (_results == null)
                {
                    _results = new List<IResult>(_view.Result.Length);
                    foreach (var result in _view.Result)
                    {
                        _results.Add(new ResultAdapter(result));
                    }
                }

                return _results;
            }
        }

        public ViewAdapter(View view)
        {
            if (view == null) throw new ArgumentNullException(nameof(view));
            _view = view;
        }
    }
}