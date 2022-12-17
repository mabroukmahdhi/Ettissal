let connectedComponentEventHandler;

export function initializeConnectedComponent(interop) {
    connectedComponentEventHandler = function () {
        interop.invokeMethodAsync("Connection.StatusChanged", navigator.onLine);
    }

    window.addEventListener("online", connectedComponentEventHandler);
    window.addEventListener("offline", connectedComponentEventHandler);

    connectedComponentEventHandler(navigator.onLine);
}

export function disposeConnectedComponent() {
    if (connectedComponentEventHandler != null) {

        window.removeEventListener("online", connectedComponentEventHandler);
        window.removeEventListener("offline", connectedComponentEventHandler);
    }
}