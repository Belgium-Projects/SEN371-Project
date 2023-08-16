document.addEventListener("DOMContentLoaded", function() {
    const chatLog = document.getElementById("chat-log");
    const userInputField = document.getElementById("user-input-field");
    const sendButton = document.getElementById("send-button");
    
    sendButton.addEventListener("click", function() {
        const userMessage = userInputField.value.trim();
        
        if (userMessage !== "") {
            appendMessage("user", userMessage);
            userInputField.value = "";
            respondToUser(userMessage);
        }
    });
    
    function appendMessage(sender, message) {
        const messageDiv = document.createElement("div");
        messageDiv.classList.add("message", sender + "-message");
        
        const messageContentDiv = document.createElement("div");
        messageContentDiv.classList.add("message-content");
        
        const labelSpan = document.createElement("span");
        labelSpan.classList.add(sender + "-label");
        labelSpan.textContent = sender === "user" ? "You:" : "Chatbot:";
        
        const textNode = document.createTextNode(message);
        messageContentDiv.appendChild(labelSpan);
        messageContentDiv.appendChild(textNode);
        
        messageDiv.appendChild(messageContentDiv);
        chatLog.appendChild(messageDiv);
        chatLog.scrollTop = chatLog.scrollHeight;
    }
    
    function respondToUser(userMessage) {
        const botResponse = generateBotResponse(userMessage);
        appendMessage("bot", botResponse);
    }
    
    function generateBotResponse(userMessage) {
        // Here, you can implement your logic to generate bot responses based on user input
        // For this example, let's use predefined responses
        const responses = {
            "hey":"Hey!  Iam Toby Premier Services Solutions Chatbot, How can I assist you?",
            "hello": "Hello!  Iam Toby Premier Services Solutions Chatbot, How can I assist you?",
            "how are you": "I'm just a bot, but I'm here to help!",
            "bye": "Goodbye! Have a great day!"
        };
        
        userMessage = userMessage.toLowerCase();
        return responses[userMessage] || "I'm not sure how to respond to that.";
    }
});
