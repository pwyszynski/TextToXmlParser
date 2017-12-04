import { Component } from '@angular/core';
import { XMLParserService } from '../../services/xmlparser.service';

@Component({
    selector: 'app',
    templateUrl: './app.component.html',
	styleUrls: ['./app.component.css'],
	providers: [XMLParserService]
})
export class AppComponent {
}
