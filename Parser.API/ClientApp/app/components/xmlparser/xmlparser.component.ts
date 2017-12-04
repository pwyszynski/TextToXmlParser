import { XMLParserService } from "../../services/xmlparser.service";
import { Component } from "@angular/core";

@Component({
	selector: 'xmlparser',
	templateUrl: './xmlparser.component.html'
})
export class XmlParserComponent {
	result: string;
	text: string;

	constructor(private xmlParser: XMLParserService) { }

	getXmlFromText() {
		this.xmlParser.getResult(this.text).subscribe(response => this.result = response.text(), error => console.log('Error parsing: ' + error))
	}
}
