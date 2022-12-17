let connectedComponentEventHandler;

export function initializeConnectedComponent(interop) {
    connectedComponentEventHandler = function () {
        interop.invokeMethodAsync("Connection.StatusChanged", navigator.onLine);
    }

    window.addEventListener("online", handler);
    window.addEventListener("offline", handler);

    connectedComponentEventHandler(navigator.onLine);
}

export function disposeConnectedComponent() {
    if (connectedComponentEventHandler != null) {

        window.removeEventListener("online", handler);
        window.removeEventListener("offline", handler);
    }
}