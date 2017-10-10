var modelDiv = '<div class="modal fade" data-backdrop="static"  id="modalMessage" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true"><div class="modal-dialog"><div class="modal-content"><div class="modal-header">'
             + '<button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button><h4 class="modal-title" id="myModalLabelHeader">Message</h4></div><div class="modal-body modal-body-sm"><p class="iSuccess" style="min-height: 50px; padding-left: 20px; padding-top: 20px;">Record Successfully Saved.</p></div>'
            + '<div class="modal-footer"><button type="button" class="btn-primary" data-dismiss="modal">OK</button></div></div></div></div>';

(function () {
    var proxied = window.alert;
    window.alert = function (msg) {
        $("body").append(modelDiv);
        $(".iSuccess").html(msg);
        if (msg.toLowerCase().indexOf("successfully".toLowerCase()) == -1) {
            $("#myModalLabelHeader").removeClass("green").addClass("red");
            $("#myModalLabelHeader").html("<span class='glyphicon glyphicon-warning-sign' style='color:red;'>&nbsp;</span> Alert");
        }
        else {
            $("#myModalLabelHeader").removeClass("red").addClass("green");
            $("#myModalLabelHeader").html("<span class='glyphicon glyphicon-ok' style='color:green;'>&nbsp;</span>Success");
        }
        $("#modalMessage").modal('show');
        //  return proxied.apply(this, arguments);
    };
})();