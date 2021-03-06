/// <reference path="../../../typings/tsd.d.ts" />

import getClientCertifiateCommand = require("commands/auth/getClientCertificateCommand");

class clientCertificateModel {
    static certificateInfo = ko.observable<Raven.Client.ServerWide.Operations.Certificates.CertificateDefinition>();
    
    static fetchClientCertificate(): JQueryPromise<Raven.Client.ServerWide.Operations.Certificates.CertificateDefinition> {
        return new getClientCertifiateCommand()
            .execute()
            .done((result: Raven.Client.ServerWide.Operations.Certificates.CertificateDefinition) => {
                this.certificateInfo(result);
            });
    }
}

export = clientCertificateModel;
