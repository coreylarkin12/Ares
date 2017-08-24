-- Write queries to return the following:
-- The following changes are applied to the "pagila" database.**
use dvdStore
-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.
INSERT INTO actor values ('Hampton', 'Avenue')
INSERT INTO actor values ('Lisa', 'Byway')
select* from actor where first_name = 'Hampton'
select*from actor where last_name = 'Byway'
-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in 
-- ancient Greece", to the film table. The movie was released in 2008 in English. 
-- Since its an epic, the run length is 3hrs and 18mins. There are no special 
-- features, the film speaks for itself, and doesn't need any gimmicks.	
INSERT INTO film (title, description, release_year, language_id, length)
 values ('Euclidean PI', '"The epic story of Euclid as a pizza delivery boy in ancient Greece"', 2008, 1, 198)

 Select*from film where title = 'Euclidean PI'
-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly 
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.
INSERT INTO film_actor (actor_id, film_id) values (202, 1001)
INSERT INTO film_actor (actor_id, film_id) values (203, 1001)

Select first_name, last_name, film_id 
From film_actor f
JOIN actor a ON a.actor_id = f.actor_id
Where a.actor_id = 203 OR a.actor_id = 202
-- 4. Add Mathmagical to the category table.
Update category
SET name = 'Mathmagical'
Where name = 'Sports'
-- 5. Assign the Mathmagical category to the following films, "Euclidean PI", 
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"
INSERT INTO film_category values (1001, 15)
INSERT INTO film_category values (274, 15)
INSERT INTO film_category values (494, 15)
INSERT INTO film_category values (714, 15)
INSERT INTO film_category values (996, 15)
-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films 
-- accordingly.
-- (5 rows affected)
UPDATE film
SET rating = 'G'
Where title = 'YOUNG LANGUAGE'

SELECT rating FROM film where title = 'YOUNG LANGUAGE'
use dvdStore
-- 7. Add a copy of "Euclidean PI" to all the stores.
INSERT INTO inventory (film_id, store_id) Values (1001, 2)
SELECT * FROM inventory where film_id = 1001
-- 8. The Feds have stepped in and have impounded all copies of the pirated film, 
-- "Euclidean PI". The film has been seized from all stores, and needs to be 
-- deleted from the film table. Delete "Euclidean PI" from the film table. 
-- (Did it succeed? Why?)
delete from inventory where film_id = 1001
-- 9. Delete Mathmagical from the category table. 
-- (Did it succeed? Why?)

-- 10. Delete all links to Mathmagical in the film_category tale. 
-- (Did it succeed? Why?)

-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI". 
-- (Did either deletes succeed? Why?)

-- 12. Check database metadata to determine all constraints of the film id, and 
-- describe any remaining adjustments needed before the film "Euclidean PI" can 
-- be removed from the film table.
