AFFICHAGE PRINCIPAL:

Menu utilisateur:

1- Se connecter à votre compte
2- Se connecter comme administrateur
3- Quitter



Si l'utilisateur choisi 1:

- Afficher message "Veuillez entrer vos identifiants"

Si l'utilisateur entre des infos enregistrées (NOM, NIP), afficher le menu du compte personnel.

AFFICHAGE MENU COMPTE PERSONNEL:

1- Changer le mot de passe
2- Déposer un montant dans un compte
3- Retirer un montant d'un compte
4- Afficher le solde du compte (Chèque ou épargne)
5- Effectuer un virement entre les comptes
6- Payer une facture
7- Fermer la session


Si l'utilisateur choisi 1:  Afficher changer votre mot de passe 
 A- Mot de passe != au mot de passe actuel.
 B- 4 caractères
 C- Tout type de caractéres
 D- Confirmer nouveau mot de passe
 E- Traitement terminé, retour au menu usager
 
 
 Si l'utilisateur choisi 2: Déposer un montant dans un compte
 A- Afficher "Choisir un compte (Chèque ou Éparge)"
 B- Lorsque l'utilisateur à choisit Chèque ou Épargne, afficher "Choisir un montant"
 C- L'utilisateur doit choisir le montant à déposer (Supérieur à 0$)
  A.N (mécanique pour valider que les données sont valides) = Seulement des chiffres sont acceptés)
 D- Lorsque le dépôt est effectué, afficher le solde u compte et retour au menu du compte.
 
  
 Si l'utilisateur choisi 3: Retirer un montant d'un compte 
  A- Afficher "quel compte à débiter"
  B- Afficher choix de l'utilisateur 
 A.N : Si montant > 10 000$, afficher message "Fonds insuffisants"
 A.N : Montant doit être = chiffres avec point et virgule/ si c'est différent, alors afficher "Veuillez entrer une valeur valide"
  C- Lorsque le dépôt est effectué, afficher le nouveau solde et retour au menu du compte
 
 
Si l'utilisateur choisi 4: Afficher le solde du compte
A- Afficher message "Veuillez sélectionner un compte (Chèque ou Épargne)"
B- Si l'utilisateur sélectionne Chèque, afficher le solde du compte Chèque.
C- Si l'utilisateur sélectionne Épargne, afficher le solde du compte Épargne.

A.N : Le montant doit être affiché dans le format xx xxx.xx$
 
 
 Si l'utilisateur choisi 5 : Effectuer un virement entre les comptes.
 A- Afficher message "Veuillez sélectionner un compte (Chèque ou Épargne)"
 B- Afficher message "Veuillez choisir le montant à virer"
 C- Si le montant choisit est inférieur à 1000$ et que le compte à suffisamment de fonds, effectuer le transfert.
 D- Si le montant choisit est supérieur à 1000$, demander le mot de passe de l'utilisateur avant d'effectuer le transfert.
 E- Si 3 tentatives de mot de passe sont utilisés, Verouillez compte.
 A.N: Le compte débiteur doit avoir suffisament de fonds.
 A.N: Le montant ne peut pas excéder 1000$.
 A.N: Lorsque le transfert est effectué, le système afficher les deux soldes.
 
 
 Si l'utilisateur choisi 6: Payer une facture.
 A- Afficher les fournisseurs disponible
 B- Lorsque l'utilisateur a entrer le fournisseur, afficher message "Veuillez entrer le numéro de facture"
 C- Lorsque l'utilisateur a entrer le numéro de facture, afficher message "Veuillez choisir un montant"
 D- Lorsque l'utilisateur a choisit un montant, afficher message "Veuillez choisir le compte duquel vous-voulez débiter le montant"
 E- Lorsque l'utilisateur a choisit le compte, valider si le solde est suffisant pour effectuer le paiement. Sinon, afficher message "fonds insuffisants"
 F- Si le solde est suffisant, demander à l'utilisateur s'il veut changer le montant.
 G- Si l'utilisateur a choisit Non, effectuer le paiement et demander s'il veut retourner au menu principal.
 
 A.N- Chaque paiement de facture inclus des frais de 2,00$.
 
 
 
 Si l'utilisateur choisi 7: Fermer la session
 A- Retour au menu principal (Si l'utilisateur veut effectuer une autre transaction, il doit resaisir son mot de passe)




Section administrateur : Si l'utilisateur choisi 2:
 
- afficher message "veuillez entrer votre nom d'utilisateur et votre mot de passe"
- si nom != admin et si mot de passe != 123456 et Si l'utilisateur fait 3 erreurs,alors guichet en panne/ afficher message erreur
- Si l'utilisateur entre des infos enregistriées, afficher le menu administrateur.
    
    si l'utilisateur choisi 1:  remettre le guichet en fonction:
    option oui: le guichet doit revenir en mode fonctionnel + retour au menu administrateur
    option non: le guichet reste en panne + retour au menu administrateur.
    
    si l'utilisateur choisi 2: déposer de l'argent dans le guichet 
      A.N :administrateur connecté 
      - afficher "c'est quoi le montant à déposer"
       si montant > 10 000$   afficher "montant maximum à déposer est de 10 000$"  
       sinon "saisir à nouveau le montant". 
      
   si l'utilisateur choisi 3 : voir le solde du guichet 
   - afficher le solde du guichet 
   - retour au menu administrateur.
  
  si l'utilisateur choisi 4: voir la liste des comptes.
  - afficher "nom du propriétaire du compte"
  - afficher le numéro de compte 
  - afficher le solde du compte
  - aficher l'état du compte verrouillé / non verouillé
  
  si l'utilisateur choisi 5: retourner au menu principal.
 






Si l'utilisateur choisi 3:

Le système se termine.