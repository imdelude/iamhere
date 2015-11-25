using System;
using System.Collections.Generic;
using iamhere.Responses.Geocoding.Contract;

namespace iamhere.Responses.Geocoding.Raw
{
    public class GeocodingResponseAdapter : IGeocodingResponse
    {
        private readonly Response _response;

        private IMetadata _metadata;
        public IMetadata Metadata => _metadata ?? (_metadata = new MetadataAdapter(_response.MetaInfo));

        private List<IView> _views;
        public IReadOnlyCollection<IView> Views
        {
            get
            {
                if (_views == null)
                {
                    _views = new List<IView>(_response.View.Length);

                    foreach (var view in _response.View)
                    {
                        _views.Add(new ViewAdapter(view));
                    }
                }

                return _views;
            }
        }

        public GeocodingResponseAdapter(Response response)
        {
            if (response == null) throw new ArgumentNullException(nameof(response));
            _response = response;
        }
    }
}