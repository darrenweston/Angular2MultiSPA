import { Component } from '@angular/core';
import { Title }     from '@angular/platform-browser';
import { Router } from '@angular/router';

import { Http, Headers } from '@angular/http';
import { securedContentHeaders, contentHeaders } from '../services/headers';

@Component({
    selector: 'login',
    templateUrl: '/partial/loginComponent'
})

export class LoginComponent {
    constructor(public router: Router, private titleService: Title, public http: Http) { }

    public setTitle(newTitle: string) {
        this.titleService.setTitle(newTitle);
    }

    public login(event: Event, username: string, password: string) {
        event.preventDefault();
        let body = 'username=' + username + '&password=' + password + '&grant_type=password';

        this.http.post('/connect/token', body, { headers: contentHeaders })
            .subscribe(response => {
                localStorage.setItem('access_token', response.json().access_token);
                this.router.navigate(['/content']);
            },
            error => {
                alert(error.text());
                console.log(error.text());
            }
            );
    }

    public signup(event: Event) {
        event.preventDefault();
        this.router.navigate(['/signup']);
    }
}
