var knap = jQuery("#minKnap");

knap.click(function () {

    console.log("12");

    jQuery.getJSON("/Home/JsonTest").done(function (data) {

        var ol = jQuery("#minListe");
        ol.empty();
        for (var i = 0; i < data.length; i++) {
            var rnd = Math.floor(Math.random() * data.length);
            var li = jQuery("<li />").html(data[rnd].Navn);
            ol.append(li);
        }

        console.log(data);
    });

});