-- The following queries utilize the "dvdstore" database.
use dvdStore
-- 1. All of the films that Nick Stallone has appeared in
-- (30 rows)
SELECT title
FROM film f
JOIN film_actor fa ON f.film_id = fa.film_id
Where actor_id = 44
-- 2. All of the films that Rita Reynolds has appeared in
-- (20 rows)
select title
From film f
JOIN film_actor fa ON f.film_id = fa.film_id
Where actor_id = 135

-- 3. All of the films that Judy Dean or River Dean have appeared in
-- (46 rows)
select title
From film f
JOIN film_actor fa ON f.film_id = fa.film_id
Where actor_id = 35 OR actor_id = 143
-- 4. All of the the ‘Documentary’ films
-- (68 rows)
SELECT f.title, c.name 
FROM film f 
JOIN film_category fc ON f.film_id=fc.film_id 
JOIN category c ON c.category_id=fc.category_id 
WHERE c.name='Documentary' 
ORDER BY f.title;
-- 5. All of the ‘Comedy’ films
-- (58 rows)SELECT f.title, c.name 
SELECT f.title, c.name 
FROM film f 
JOIN film_category fc ON f.film_id=fc.film_id 
JOIN category c ON c.category_id=fc.category_id 
WHERE c.name='Comedy' 
ORDER BY f.title;

-- 6. All of the ‘Children’ films that are rated ‘G’
-- (10 rows)
SELECT f.title, f.rating, c.name 
FROM film f 
JOIN film_category fc ON f.film_id=fc.film_id 
JOIN category c ON c.category_id=fc.category_id 
WHERE c.name = 'Children' AND f.rating = 'G'
ORDER BY f.rating;

-- 7. All of the ‘Family’ films that are rated ‘G’ and are less than 2 hours in length
-- (3 rows)
SELECT f.title, f.rating, f.length, c.name 
FROM film f 
JOIN film_category fc ON f.film_id=fc.film_id 
JOIN category c ON c.category_id=fc.category_id 
WHERE c.name = 'Family' AND f.rating = 'G' AND f.length < 120
ORDER BY f.length;
-- 8. All of the films featuring actor Matthew Leigh that are rated ‘G’
-- (9 rows)
SELECT title, rating
FROM film f
JOIN film_actor fa ON f.film_id = fa.film_id
Where actor_id = 103 AND rating = 'G'
-- 9. All of the ‘Sci-Fi’ films released in 2006
-- (61 rows)
SELECT f.title, f.release_year, c.name 
FROM film f 
JOIN film_category fc ON f.film_id=fc.film_id 
JOIN category c ON c.category_id=fc.category_id 
WHERE c.name = 'Sci-Fi' AND f.release_year = 2006

-- 10. All of the ‘Action’ films starring Nick Stallone
-- (2 rows)
SELECT f.title, f.rating, c.name 
FROM film f 
JOIN film_category fc ON f.film_id=fc.film_id 
JOIN category c ON c.category_id=fc.category_id 
WHERE c.name = 'Children'
ORDER BY f.rating;
-- 11. The address of all stores, including street address, city, district, and country
-- (2 rows)
select address, district, city_id
from address a
JOIN store s on a.address_id = s.address_id
Where a.address_id = 1 OR a.address_id = 2

-- 12. A list of all stores by ID, the store’s street address, and the name of the store’s manager
-- (2 rows)
select store_id, manager_staff_id, address_id from store
-- 13. The first and last name of the top ten customers ranked by number of rentals 
-- (#1 should be “ELEANOR HUNT” with 46 rentals, #10 should have 39 rentals)
SELECT Top 10 payment.*, customer.first_name, customer.last_name, rental.return_date 
FROM payment JOIN customer ON payment.customer_id = customer.customer_id
JOIN rental ON rental.rental_id = payment.rental_id

-- 14. The first and last name of the top ten customers ranked by dollars spent 
-- (#1 should be “KARL SEAL” with 221.55 spent, #10 should be “ANA BRADLEY” with 174.66 spent)
SELECT top 10 amount
FROM payment

-- 15. The store ID, street address, total number of rentals, total amount of sales (i.e. payments), and average sale of each store 
-- (Store 1 has 7928 total rentals and Store 2 has 8121 total rentals)

-- 16. The top ten film titles by number of rentals
-- (#1 should be “BUCKET BROTHERHOOD” with 34 rentals and #10 should have 31 rentals)

-- 17. The top five film categories by number of rentals 
-- (#1 should be “Sports” with 1179 rentals and #5 should be “Family” with 1096 rentals)

-- 18. The top five Action film titles by number of rentals 
-- (#1 should have 30 rentals and #5 should have 28 rentals)

-- 19. The top 10 actors ranked by number of rentals of films starring that actor 
-- (#1 should be “GINA DEGENERES” with 753 rentals and #10 should be “SEAN GUINESS” with 599 rentals)

-- 20. The top 5 “Comedy” actors ranked by number of rentals of films in the “Comedy” category starring that actor 
-- (#1 should have 87 rentals and #5 should have 72 rentals)
SELECT top 5 f.rental_rate, c.name
FROM film f 
JOIN film_category fc ON f.film_id=fc.film_id 
JOIN category c ON c.category_id=fc.category_id 
WHERE c.name='Comedy' 
ORDER BY f.title;
