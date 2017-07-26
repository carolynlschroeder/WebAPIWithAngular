import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/map';
import 'rxjs/add/observable/throw';


import { IContact } from './contact';


@Injectable()
export class ContactService {
    private _contactsUrl = 'http://localhost:56680/api/contacts';

    constructor(private _http: Http) { }

    getContacts(): Observable<IContact[]> {

        return this._http.get(this._contactsUrl)
        .map((response: Response)=><IContact[]>response.json());

    }
}


