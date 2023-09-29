if ('speechSynthesis' in window) {
    var message = new SpeechSynthesisUtterance();
    message.text = "Hello, this is a test.";

    // Set the voice explicitly if available
    var voices = window.speechSynthesis.getVoices();
    if (voices.length > 0) {
        message.voice = voices[0]; // Use the first available voice
    }

    window.speechSynthesis.speak(message);
} else {
    console.error("Speech synthesis is not supported in this browser.");
}
