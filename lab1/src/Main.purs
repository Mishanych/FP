module Main where

import Prelude

import Effect (Effect)
import Effect.Console (log)
import Data.List (List(..), (:))
import Data.Maybe (fromMaybe,Maybe(..))
import Data.Foldable (foldr)

singleton :: forall a. a -> List a
singleton a = a : Nil

null :: forall a. List a -> Boolean
null Nil = true
null _ = false

snoc :: forall a. List a -> a -> List a
snoc list el = foldr (:) (el : Nil) list

tail :: forall a. List a -> Maybe (List a)
tail Nil = Nothing
tail (_ : list) = Just list

length :: forall a. List a -> Int
length list =
  if null list
    then 0
    else 1 + (length ( fromMaybe Nil (tail list)))

task1 :: Int
task1 = 10

task2 :: List Int
task2 = 1 : 2 : Nil

task3List :: List Int
task3List = 1 : 2 : 3 : Nil

task3El :: Int
task3El = 4

task4 :: List Int
task4 = 1 : 2 : Nil

main :: Effect Unit
main = do
  log ("Task 1 " <> show (singleton task1))
  log ("Task 2 " <> show (null task2))
  log ("Task 3 " <> show (snoc task3List task3El))
  log ("Task 4 " <> show (length task4))