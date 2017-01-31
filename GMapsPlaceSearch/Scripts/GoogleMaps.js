// This example requires the Places library. Include the libraries=places
// parameter when you first load the API. For example:
// <script src="https://maps.googleapis.com/maps/api/js?key=YOUR_API_KEY&libraries=places">

var map;
var selectedobject;
(function () {

    function reMap() {
        map = new google.maps.Map(document.getElementById('map'), {
            center: {
                lat: -33.8688,
                lng: 151.2195
            },
            zoom: 4
        });
    }

    function initMap() {
        reMap();
        var input = document.getElementById('pac-input');

        var autocomplete = new google.maps.places.Autocomplete(input);

        // Set initial restrict to the greater list of countries.
        autocomplete.setComponentRestrictions({
            'country': ['aus']
        });

        autocomplete.addListener('place_changed', function () {
            var place = autocomplete.getPlace();
            reMap();
            showData(place, 0);
            fillDbData(place.formatted_address);
        });

        $('#linkList').on('click', 'li', function () {
            selectedobject = $(this).text();
            fillDbData($(this).text());
        });
    }

    function showData(place, zoom) {

        var contentString = '<div id="infowindow-content">' +
          '<img src="" width="16" height="16" id="place-icon">' +
          '<span id="place-name" class="title"></span>' +
          '<br>' +
          '<span id="place-address"></span>' +
          '</div>';

        var infowindow = new google.maps.InfoWindow();

        var infowindowContent = $.parseHTML(contentString)[0];
        infowindow.setContent(infowindowContent);

        var marker = new google.maps.Marker({
            map: map,
            anchorPoint: new google.maps.Point(0, -29)
        });

        marker.addListener('click', function () {
            infowindow.open(map, marker);
        });

        if (!place.geometry) {
            // User entered the name of a Place that was not suggested and
            // pressed the Enter key, or the Place Details request failed.
            //window.alert("No details available for input: '" + place.name + "'");
            window.alert("Please select location from list.");
            return;
        }
        // If the place has a geometry, then present it on a map.
        if (zoom == 0 || selectedobject == place.formatted_address) {
            if (place.geometry.viewport) {
                map.fitBounds(place.geometry.viewport);
            } else {
                map.setCenter(place.geometry.location);
                map.setZoom(17); // Why 17? Because it looks good.
            }
        }

        marker.setPosition(place.geometry.location);
        marker.setVisible(true);

        var address = '';
        if (place.address_components) {
            address = [
              (place.address_components[0] && place.address_components[0].short_name || ''),
              (place.address_components[1] && place.address_components[1].short_name || ''),
              (place.address_components[2] && place.address_components[2].short_name || '')
            ].join(' ');
            if (place.icon === undefined) {
                infowindowContent.children['place-icon'].src = "http://maps.google.com/mapfiles/kml/pal5/icon14.png";
            } else {
                infowindowContent.children['place-icon'].src = place.icon;
            }

            infowindowContent.children['place-name'].textContent = place.name;
            infowindowContent.children['place-address'].textContent = address;
        } else {
            console.log('Not found');
        }
    }

    function fillDbData(parameter) {
        $.ajax({
            url: "api/realestate",
            data: {
                "street": parameter
            },
            type: "POST",
            success: function (data) {
                $('#linkList').empty();
                $.each(data, function (key, val) {
                    codeAddress(val.Street);
                    var $li = $("<li><a href='#'>" + val.Street + "</a></li>");
                    $("#linkList").append($li);
                });
            }
        });
    };


    function codeAddress(address) {

        // Define address to center map to
        var geocoder = new google.maps.Geocoder();
        var obj = {};
        geocoder.geocode({
            'address': address
        }, function (results, status) {

            if (status == google.maps.GeocoderStatus.OK) {

                if (results[0] != "undefined") {
                    showData(results[0], 1);
                }
            } else {

                alert("Geocode was not successful for the following reason: " + status);
            }
        });
        return;
    }

    initMap();

})();
