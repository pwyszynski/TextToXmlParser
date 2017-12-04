import { XMLParserService } from "../../services/xmlparser.service";
import { Component, OnInit } from "@angular/core";

@Component({
	selector: 'xmlparser',
	templateUrl: './xmlparser.component.html'
})
export class XmlParserComponent implements OnInit {
	result: string;
	text: string;

	constructor(private xmlParser: XMLParserService) { }

	ngOnInit() {
		this.text = "";
	}

	getXmlFromText() {
		var textToSend: string;

		var trigger = this.text,
			regexp = new RegExp('"[\\s\\S]*"'),
			test = regexp.test(trigger);

		if (test == false) {
			textToSend = "\"" + this.text + "\"";
		}
		else {
			textToSend = this.text;
		}

		this.xmlParser.getResult(textToSend).subscribe(response => this.result = response.text(), error => console.log('Error parsing: ' + error))
	}

	resetText() {
		this.text = "";
		this.result = "";
	}
}
