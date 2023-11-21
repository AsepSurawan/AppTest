
function RequestData(type, url, container, field, params, callback) {
    console.log("masuk");
    $.ajax({
        async: true,
        type: type,
        url:window.location.origin + url,
        dataType: 'json',
        data: params,
        beforeSend: function (xhr) {
            if (container != undefined && container != null && container != "")
                ShowLoading(container);
        },
        error: function (err) {
            if (container != undefined && container != null && container != "")
                $(container).waitMe('hide');
            //ShowNotif("Error !", "Something went wrong", "error");
            console.log("error", err);
            
        },
        success: function (data) {
            if (field != undefined && field != null && field != "")
                $(field).html('');

            if (container != undefined && container != null && container != "")
                $(container).waitMe('hide');

            if (callback != undefined && callback != null && callback != "")
                return callback(data);
        }
    });
}

function RequestFormData(type, url, container, field, params, callback) {
    console.log("masuk");
    $.ajax({
        async: true,
        type: type,
        url: window.location.origin + url,
        contentType: false,
        processData: false,
        data: params,
        beforeSend: function (xhr) {
            if (container != undefined && container != null && container != "")
                ShowLoading(container);
        },
        error: function (err) {
            if (container != undefined && container != null && container != "")
                $(container).waitMe('hide');
            //ShowNotif("Error !", "Something went wrong", "error");
            console.log("error", err);

        },
        success: function (data) {
            if (field != undefined && field != null && field != "")
                $(field).html('');

            if (container != undefined && container != null && container != "")
                $(container).waitMe('hide');

            if (callback != undefined && callback != null && callback != "")
                return callback(data);
        }
    });
}


function ShowLoading(target, effect = 'win8_linear', message = 'Pleas Wait..', callback = null) {
    $(target).waitMe({
        effect: effect,
        text: message !== undefined || message !== null ? message : '',
        bg: 'rgba(255,255,255,0.7)',
        color: '#000',
        maxSize: '',
        waitTime: -1,
        textPos: 'vertical',
        fontSize: '',
        source: '',
        onClose:function () {
        }
    });
}

function ShowNotif(title,message,type)
{
    Swal.fire(title, message, type);
}

function NumberToRupiah(value) {
    var result = "0";
    if (value != undefined && value != null && value != "" && value != 0) {
        var rupiah = '';
        var angkarev = value.toString().split('').reverse().join('');
        for (var i = 0; i < angkarev.length; i++)
            if (i % 3 == 0) rupiah += angkarev.substr(i, 3) + '.';
        result ="Rp "+ rupiah.split('', rupiah.length - 1).reverse().join('');

    }
    return result;
}

function RupiahToNumber(value, int_numb) {
    var result = 0;
    if (int_numb == null)
        int_numb = 12
    if (value != undefined && value != null && value != "" && value != "0") {
       // result = parseInt(value.replace(/[^0-9]/g, ''), int_numb);
        result = value.replace(/[^0-9]/g, '');
    }
    return result;
}

function FormatRupiah(angka, prefix) {
    var number_string = angka.replace(/[^,\d]/g, '').toString(),
        split = number_string.split(','),
        sisa = split[0].length % 3,
        rupiah = split[0].substr(0, sisa),
        ribuan = split[0].substr(sisa).match(/\d{3}/gi);

    // tambahkan titik jika yang di input sudah menjadi angka ribuan
    if (ribuan) {
        separator = sisa ? '.' : '';
        rupiah += separator + ribuan.join('.');
    }

    rupiah = split[1] != undefined ? rupiah + ',' + split[1] : rupiah;
    return prefix == undefined ? rupiah : (rupiah ? 'Rp. ' + rupiah : '');
}

const getInitials = name => name
    .replace(/[^A-Za-z0-9À-ÿ ]/ig, '')        // taking care of accented characters as well
    .replace(/ +/ig, ' ')                     // replace multiple spaces to one
    .split(/ /)                               // break the name into parts
    .reduce((acc, item) => acc + item[0], '') // assemble an abbreviation from the parts
    .concat(name.substr(1))                   // what if the name consist only one part
    .concat(name)                             // what if the name is only one character
    .substr(0, 2)                             // get the first two characters an initials
    .toUpperCase();

const BgColor = ["bg-primary", "bg-secondary", "bg-gray", "bg-success", "bg-danger", "bg-warning", "bg-info"];