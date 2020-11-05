import { UserManagerSettings } from 'oidc-client';

export class ChenilSettings implements UserManagerSettings{
    readonly popup_redirect_uri?: string;
    authority?: string;
    readonly silent_redirect_uri?: any;
    client_id?: string;
    readonly redirect_uri?: string;

    public constructor(){
        this.popup_redirect_uri='https://localhost:4200/authentication/login-callback';
        this.authority='https://localhost:10443/';
        this.silent_redirect_uri='https://localhost:4200/authentication/login-callback';
        this.client_id= 'Developpement';
        this.redirect_uri='https://localhost:4200/authentication/login-callback';
    }
}