'use strict';
chrome.storage.sync.get(['srvMSOTL'], function(data) {
	if (!data.srvMSOTL)
		chrome.storage.sync.set({'srvMSOTL': 'localhost:8082'}, function() {
			console.log('Settings saved');
		});
});








