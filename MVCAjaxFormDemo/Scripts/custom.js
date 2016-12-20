function displayMessage(message) {
    $('#myMessageModal').modal('show');
    $("#myMessageModal p#myMessageModalMessage").html(message);
}