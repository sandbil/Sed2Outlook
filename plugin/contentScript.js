(function (){
    let extnsId = chrome.runtime.id;
    let extnsVer = chrome.runtime.getManifest().version;
    console.info('start content script СЭД2Outlook extension ver.', extnsVer, ', id:', extnsId);
    chrome.storage.sync.get(['srvMSOTL','login'], function(data) {
        let srvMSOTL = data.srvMSOTL;
        let docId = /\/document\/([abcdef0-9]+)/.exec(location.pathname)[1];
        console.debug('service address:port - ', srvMSOTL);
        if (srvMSOTL) {
            let divTools = document.querySelectorAll('.tools');
            if (divTools.length = 1) {
                let btn = document.createElement("button");
                btn.setAttribute('class','sed-btn sed-btn-green sed-fs-12');
                btn.setAttribute('style','margin-left: 20px;');
                btn.setAttribute('onclick', 'sendMSOtl()');
                btn.innerText = "Отправить Email";
                divTools[0].appendChild(btn)

                let sendMSOtl = "function sendMSOtl(){" +
                    "let url = 'http://"+srvMSOTL+"/add?id=" + docId + "&token=" + localStorage["token01"] + "';\n" +
                    "console.debug(url);" +
                    "fetch(url).then((response) => {\n" +
                    "  if (response.ok) {\n" +
                    "    return response.json();\n" +
                    "  } else {\n" +
                    "    throw new Error('Something went wrong');\n" +
                    "  }\n" +
                    "})\n" +
                    ".then((responseJson) => {\n" +
                    "  // Do something with the response\n" +
                    "})\n" +
                    ".catch((error) => {\n" +
                    "  console.log(error)\n" +
                    "});" +
                    "}";
                let script = document.createElement("script");
                script.type='text/javascript';
                script.innerHTML = sendMSOtl;
                document.head.appendChild(script);
            };
        }

    });


/*
    function findToolsDiv() {

    };

    findToolsDiv();

	// создаём экземпляр MutationObserver
	let observer = new MutationObserver(function(mutations){
        findToolsDiv();
	});
        // конфигурация нашего observer:
	let config = { attributes: true, childList: true, characterData: true };
	// передаём в качестве аргументов целевой элемент и его конфигурацию
	observer.observe(document.body, config);
*/

})();
