

// fields
var fields = {
		"width_percent"		: "width_percent",
		"height_percent"	: "height_percent",
		"position"			: "position",
		"service"			: "service_url",
		"inventnum"			: "inventnum_url",
		"from_lang" 		: "from_lang",
		"to_lang"			: "to_lang",
		"docUrlPtrns"		: "docUrlPtrns"
};

//default values
var defaults = {};
defaults[fields["width_percent"]]	= 0.85;
defaults[fields["height_percent"]]	= 0.85;
defaults[fields["position"]]		= "C";
defaults[fields["service"]]			= "http://10.75.112.14/_r_graph/gkn/index.rb?cn=";
defaults[fields["inventnum"]]		= "http://10.75.113.104:3000/getinvnmb?adr=&cadn=";
defaults[fields["docUrlPtrns"]] 	= ["*://pkurp-app-balancer-01.egron.test/*", "*://pkurp-app-balancer-01.prod.egrn/*"];

function getFieldValue(field, default_value) {
	var value = localStorage[field];
	if (!value) {
		value = default_value;
	}

	return value;
}

function saveFieldValue(field, value) {
	localStorage[field] = value;
}

