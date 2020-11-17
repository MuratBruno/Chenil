import { UserManagerSettings } from 'oidc-client';

export class ChenilSettings implements UserManagerSettings{
    readonly popup_redirect_uri?: string;
    authority?: string;
    readonly silent_redirect_uri?: any;
    client_id?: string;
    readonly redirect_uri?: string;
    readonly response_type?: string;

    public constructor(){
        this.popup_redirect_uri='https://localhost:4202/authentication/login-callback';
        this.authority='https://localhost:10443/';
        this.silent_redirect_uri='https://localhost:4202/authentication/login-callback';
        this.client_id= 'Docker';
        this.redirect_uri='https://localhost:4202/authentication/login-callback';
        this.response_type='id_token token';
    }
}