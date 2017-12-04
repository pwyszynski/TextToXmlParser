import { Injectable } from "@angular/core";
import { Http, Response, Headers } from "@angular/http";
import { Observable } from "rxjs/Observable";

const httpOptions = {
	headers: new Headers({ 'Content-Type': 'application/json' })
}


@Injectable()
export class XMLParserService {
	private baseUrl: string = "/api/XMLParser/";

	constructor(private http: Http) { }

	getResult(text: string): Observable<Response> {
		var ob = this.http.post(this.baseUrl + "ParseSentence", text, httpOptions);

		return ob;
	}
}