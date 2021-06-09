window.playaudio = (sound, id) => {
    var audioPlayer = new Audio(sound);
    audioPlayer.onended = () => {
        if (id !== "") {
            $(`#${id}`).removeClass("highlight");;
        }
    }


    audioPlayer.play();

    if (id !== "") {
        $(`#${id}`).addClass("highlight");;
    }
}