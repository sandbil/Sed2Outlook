
chrome.storage.sync.get(['srvMSOTL'], function(data) {
    document.getElementById('inpSrvMSOTL').value = data.srvMSOTL;
});

document.getElementById('inpSrvMSOTL').onchange = function() {
  chrome.storage.sync.set({'srvMSOTL': this.value}, function() {
    console.log('Settings saved');
  });
}




